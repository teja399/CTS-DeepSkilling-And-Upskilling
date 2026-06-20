function greetUser(name) {
    return `Welcome, ${name}!`;
}

function registrationCounter() {
    let count = 0;

    return function () {
        count++;
        console.log("Registrations:", count);
    };
}

const increment = registrationCounter();

function registerUser() {
    alert(greetUser("Deepika"));
    increment();
}
