function Event(name, date, location) {
    this.name = name;
    this.date = date;
    this.location = location;
}

Event.prototype.display = function () {
    return `${this.name} - ${this.date} - ${this.location}`;
};

const event1 = new Event(
    "Technology Workshop",
    "20 July 2026",
    "Community Hall"
);

document.getElementById("output").innerHTML =
    event1.display();
