var switchButton = document.getElementById("switchButton");
var inputTags = document.querySelectorAll("input:not([type='hidden'])");

switchButton.onclick = function () {
    if (inputTags[0].disabled === true) {
        for (var i = 0; i < inputTags.length; i++) {
            inputTags[i].removeAttribute("disabled");
        }
        switchButton.textContent = "取消";
    } else {
        for (var i = 0; i < inputTags.length; i++) {
            inputTags[i].setAttribute("disabled", "disabled");
        }
        switchButton.textContent = "修改";
    }
}