using Mediator._01;
using static System.Console;

// Call center as the Mediator
var callCenter = new CallCenter();


// Cabs
var cab1 = new Cab("Mohammad Nabi", 3, true);
var cab2 = new Cab("Shamsullah Shamsi", 4, false);
var cab3 = new Cab("Abdul Malik", 10, true);
var cab4 = new Cab("Mohammad Agha", 3, true);

// Passengers
var passenger1 = new Passenger("Ahmad", "District #3", 5);
var passenger2 = new Passenger("Khan", "District #5", 20);

// Register Cabs on Mediator
callCenter.Register(cab1);
callCenter.Register(cab2);
callCenter.Register(cab3);
callCenter.Register(cab4);

// Assign passengers to call center
callCenter.BookCab(passenger1);
callCenter.BookCab(passenger2);
