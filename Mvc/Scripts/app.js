//(function () {
$(document).ready(function () {
    $(".tile > a").click('click', function (evt) {
        evt.preventDefault();
        var $content = $("#content");

        $content.html("");

        var $target = $(evt.target);
        var link = $target.closest("a");
        var color = link.data('color');

        console.log(color);

        //$.getJSON("/api/colorme/"+ color,
        //function (data) {
        //    var contentData = $.parseJSON(data);
        //    $content.html(contentData.content);
        //});

        $.getJSON("/nancy/colormebad/"+color, { },
        function (data) {
            var contentData = eval(data);
        $content.html(contentData.content);
        });
    });
});

//})(jQuery);