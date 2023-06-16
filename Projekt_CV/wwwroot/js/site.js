// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const contactMeButton = document.querySelector('.contactme-button');
const contact = document.querySelector('.contact');
const myProjectsButton = document.querySelector('.my-projects-button');
const portfolio = document.querySelector('.portfolio');
const description = document.querySelector('.description');
const aboutLink = document.querySelector('#about');
const portfolioLink = document.querySelector('#portfolio');
const contactLink = document.querySelector('#contact');

contactMeButton.addEventListener('click', () => {
    contact.scrollIntoView({ behavior: "smooth", block: "end", inline: "nearest" });
})

myProjectsButton.addEventListener('click', () => {
    portfolio.scrollIntoView({ behavior: "smooth", block: "end", inline: "nearest" });
})

aboutLink.addEventListener('click', () => {
    description.scrollIntoView({ behavior: "smooth", block: "end", inline: "nearest" });
})

portfolioLink.addEventListener('click', () => {
    portfolio.scrollIntoView({ behavior: "smooth", block: "end", inline: "nearest" });
})

contactLink.addEventListener('click', () => {
    contact.scrollIntoView({ behavior: "smooth", block: "end", inline: "nearest" });
})
