// 所有 input
var inputTags = document.querySelectorAll("input");

// 所有 button
var upsertButton = document.getElementById("upsertButton");
var cancelButton = document.getElementById("cancelButton");
var submitButton = document.getElementById("submitButton");

function upsert() {
    // 清除 input 的 disabled 屬性
    for (var i = 0; i < inputTags.length; i++) {
        inputTags[i].removeAttribute("disabled");
    }

    // 增加 disabled
    upsertButton.setAttribute("disabled", "disabled");

    // 移除 disabled
    cancelButton.removeAttribute("disabled");
    submitButton.removeAttribute("disabled");
}

function cancel() {
    window.location.href = "/Setting/Company/Index/1"
}