const events = [
    {
        name: "Technology Workshop",
        seats: 20,
        isPast: false
    },
    {
        name: "Music Festival",
        seats: 0,
        isPast: false
    },
    {
        name: "Art Expo",
        seats: 15,
        isPast: true
    }
];

const list = document.getElementById("eventList");

events.forEach(event => {

    if (!event.isPast && event.seats > 0) {

        const li = document.createElement("li");
        li.textContent = `${event.name} - Seats Available: ${event.seats}`;

        list.appendChild(li);

    }

});

function register(event) {

    try {

        if (event.seats <= 0) {
            throw new Error("No seats available");
        }

        event.seats--;

        console.log("Registration successful");

    }
    catch (error) {

        console.error(error.message);

    }

}

register(events[0]);
register(events[1]);
