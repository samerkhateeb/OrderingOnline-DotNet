var imagesList ,
    i = 0,
    HotNewsImage,
    HotNewsLink;

//imagesList = [['/Assets/images/HotNews_Image.gif', 'http://www.google.com'], ['/Assets/images/All.gif', 'http://www.hotmail.com']]

$(function () {

    ChangeImage(0);
});


function ChangeImage(i) {

    HotNewsImage = $('#HotNewsImage');
    HotNewsLink = $('#HotNewsLink');
    HotNewsImage.hide()
                .attr('src', imagesList[i][0])
                .fadeIn('slow')
                ;

    HotNewsLink.attr('href', imagesList[i][1]);

    i++;
    if (i == parseInt(imagesList.length)) 
        i = 0;
    
    setTimeout(function () {
        ChangeImage(i);
    }, 4000);

}


