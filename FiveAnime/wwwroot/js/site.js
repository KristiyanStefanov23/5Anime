document.body.onload = function () {
    if (GetLastFiveFromUrl()) {
        let partToRemove = document.querySelector('.col-md-6');
        partToRemove.parentNode.removeChild(partToRemove);
    }
}

function GetLastFiveFromUrl() {
    let lastFive = window.location.href.substr(window.location.href.length - 5);
    if (lastFive === "Login") return true;
    return false
}