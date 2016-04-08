$('.tag').each(function () {
    this.addEventListener('click', function () {
        $('#classes').empty();
        for (var i = 0; i < classes.length; i++)
            if (classes[i].indexOf(this.innerText) != -1)
                $('#classes').append('<li>' + classes[i] + '</li>');
    });
});

$('.nav li a').each(function () {
    this.addEventListener('click', function (e) {
        if (this.baseURI === this.href)
            e.preventDefault();
    });
});