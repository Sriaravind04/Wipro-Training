function showMessage() {
    alert("Thanks for clicking! ");
}

function submitForm(event) {
    event.preventDefault();
    alert("Message sent successfully!");

    event.target.reset();
}