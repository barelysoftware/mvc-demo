//(function () {
$(document).ready(function() {
    $(".tile > a").click('click', function(evt) {
        evt.preventDefault();
        var $content = $("#content");

        $content.html("");

        var $target = $(evt.target);
        var link = $target.closest("a");
        var color = link.data('color');

        console.log(color);

        $.getJSON("/api/colorme/", { 'color': color },function(data) {
            $content.html(data);
        });
    });
});

//})(jQuery);