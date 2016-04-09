$('.tag').each(function () {
    this.addEventListener('click', function () {
        var totalClasses = 0;
        $('#classes').empty();
        $('#total-classes').empty();

        for (var i = 0; i < classes.length; i++) {
            if (classes[i].indexOf(this.innerText) != -1) {
                $('#classes').append('<li>' + classes[i] + '</li>');
                totalClasses++;
            }
        }

        $('#total-classes').text(totalClasses);
    });
});

$('.nav li a').each(function () {
    this.addEventListener('click', function (e) {
        if (this.baseURI === this.href)
            e.preventDefault();
    });
});