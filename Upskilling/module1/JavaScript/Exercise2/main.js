const eventName = "Technology Workshop";
const eventDate = "20 July 2026";

let availableSeats = 50;

availableSeats--;

const eventInfo = `
Event Name: ${eventName}<br>
Event Date: ${eventDate}<br>
Available Seats: ${availableSeats}
`;

document.getElementById("eventInfo").innerHTML = eventInfo;
