const hum = document.querySelector('.navHome');
const nav_links = document.querySelector('.nav-links');
const lisk = document.querySelector(".nav-links li");

hum.addEventListener('click', () => {
    nav_links.classList.toggle('open');
    lisk.forEach(link => {
        link.classList.toggle('fade');
    });
});