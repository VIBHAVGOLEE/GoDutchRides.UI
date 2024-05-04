/*// Select the element with the id "LoginPopup"
const loginPopup = document.getElementById("LoginPopup");

// Add a click event listener to the element
loginPopup.addEventListener("click", function () {
    // Your code to handle the click event goes here
    // For example, you could open the login form or perform any other action
    console.log("LoginPopup clicked!");
});*/

// Get the modal element
const modal = document.getElementById("loginModal");

// Get the button that opens the modal
const openModalBtn = document.getElementById("openModalBtn");

// Get the close button element
const closeBtn = document.querySelector(".close");

// Get the signup link
const signupLink = document.getElementById("signupLink");

// Function to open the modal
function openModal() {
    modal.classList.remove("hidden");
}

// Function to close the modal
function closeModal() {
    modal.classList.add("hidden");
}

// Event listener for the open modal button
openModalBtn.addEventListener("click", openModal);

// Event listener for the close button
closeBtn.addEventListener("click", closeModal);

// Event listener for the signup link
signupLink.addEventListener("click", function (event) {
    event.preventDefault(); // Prevent the default action of the link
    // You can implement your signup logic here, such as showing another modal for signup
    console.log("Signup link clicked!");
});

// Event listener for the login form submission
document.getElementById("loginForm").addEventListener("submit", function (event) {
    event.preventDefault(); // Prevent form submission
    // You can implement your login logic here, such as sending login request to server
    console.log("Login form submitted!");
});

