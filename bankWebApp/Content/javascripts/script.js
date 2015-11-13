function start() {
    var buttonsShow = document.querySelectorAll('input[value="+"]');

    for (var i = 0; i < buttonsShow.length; i++) {
        document.getElementById(buttonsShow[i].name).style.display = "none";
        buttonsShow[i].addEventListener("click", function () {
            if (document.getElementById(this.name).style.display != "none") {
                document.querySelector(".modelDiv").style.float = "none";
                document.querySelector(".modelDiv").style.width = "500px";
                document.querySelector(".wrapper").style.display = "none";
                document.getElementById(this.name).style.display = "none";
                this.setAttribute("src", "/Content/images/right.png");
            } else {
                document.querySelector(".wrapper").style.display = "inline-block";
                document.querySelector(".modelDiv").style.float = "left";
                document.querySelector(".modelDiv").style.width = "400px";
                var allDivs = document.querySelectorAll('.descriptor');
                for (var j = 0; j < allDivs.length; j++) {
                    allDivs[j].style.display = "none";
                }
                var allButtons = document.querySelectorAll('input[value="+"]');
                for (var j = 0; j < allButtons.length; j++) {
                    allButtons[j].setAttribute("src", "/Content/images/right.png");
                }
                document.getElementById(this.name).style.display = "block";
                this.setAttribute("src", "/Content/images/cancel.png");
            }
        });
    }
}
