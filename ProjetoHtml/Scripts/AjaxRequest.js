var AjaxRequest = function(url, type, data) {
    this.url = url;
    this.type = type;
    this.data = data;

    this.makeRequest = function () {

        return $.ajax({
            url: this.url,
            contentType: "application/json; charset=utf8",
            type: this.type,
            data: JSON.stringify(this.data),
        });
    };

}