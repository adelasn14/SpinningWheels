let idleTime = 0;
const idleTimeout = 10; // 5 minutes in seconds
const homePageUrl = "/Home/Index"; // Adjust the URL of your home page

const idleInterval = setInterval(timerIncrement, 1000);

document.addEventListener('mousemove', resetIdleTime);
document.addEventListener('keydown', resetIdleTime);

function timerIncrement() {
    idleTime++;
    if (idleTime >= idleTimeout) {
        window.location.href = homePageUrl;
    }
}

function resetIdleTime() {
    idleTime = 0;
}