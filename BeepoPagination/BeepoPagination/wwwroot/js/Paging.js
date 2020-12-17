
var ajaxResp = $.ajax({
	url: 'https://jsonplaceholder.typicode.com/users',
	dataType: 'json',
	success: function (data) {
		for (var i = 0; i < data.length; i++) {
			var row = $('<tr><td>' + data[i].id + '</td><td>' + data[i].name + '</td><td>' + data[i].username + '</td></tr>');
            $('#myTable').append(row);
		}
	},
	error: function (jqXHR, textStatus, errorThrown) {
		alert('Error: ' + textStatus + ' - ' + errorThrown);
	}
});

var ajaxResponse = $.ajax({
    url: "https://jsonplaceholder.typicode.com/users",
    dataType: "jsonp"
    })
    .done(function () {
        console.log("success");
    })
    .fail(function () {
        console.log("error");
    })
    .always(function () {
        console.log('complete');
});


var current_page = 1;
var records_per_page = 2;

var objJson = ajaxResponse// Can be obtained from another source, such as your objJson variable

function prevPage() {
    if (current_page > 1) {
        current_page--;
        changePage(current_page);
    }
}

function nextPage() {
    if (current_page < numPages()) {
        current_page++;
        changePage(current_page);
    }
}

function changePage(page) {
    var btn_next = document.getElementById("btn_next");
    var btn_prev = document.getElementById("btn_prev");
    var listing_table = document.getElementById("listingTable");
    var page_span = document.getElementById("page");

    // Validate page
    if (page < 1) page = 1;
    if (page > numPages()) page = numPages();

    listing_table.innerHTML = "";

    ////
    console.log(ajaxResp.responseJSON);

    for (var i = (page - 1) * records_per_page; i < (page * records_per_page); i++) {
        listing_table.innerHTML += objJson.responseJSON[i].id + objJson.responseJSON[i].name + objJson.responseJSON[i].username + "<br>";
    }
    page_span.innerHTML = page;

    if (page == 1) {
        btn_prev.style.visibility = "hidden";
    } else {
        btn_prev.style.visibility = "visible";
    }

    if (page == numPages()) {
        btn_next.style.visibility = "hidden";
    } else {
        btn_next.style.visibility = "visible";
    }
}

function numPages() {
    return Math.ceil(objJson.responseJSON.length / records_per_page);
}

window.onload = function () {
    changePage(1);
};
