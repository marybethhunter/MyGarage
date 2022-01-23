// See https://aka.ms/new-console-template for more information

using MyGarage.Models;
using System.Collections.Generic;

// Build a collection of all vehicles that fly
// With a single `foreach`, have each vehicle Fly()

// Build a collection of all vehicles that operate on roads
// With a single `foreach`, have each road vehicle Drive()

// Build a collection of all vehicles that operate on water
// With a single `foreach`, have each water vehicle Drive()

//1.
var aircrafts = new List<Aircraft>();
var hotAirBalloon = new HotAirBalloon();
aircrafts.Add(hotAirBalloon);
foreach (var aircraft in aircrafts)
{
    aircraft.Fly();
}

//2.
var roadVehicles = new List<Car>();
var nissanLeaf = new NissanLeaf();
var monsterTruck = new MonsterTruck();
roadVehicles.Add(nissanLeaf);
roadVehicles.Add(monsterTruck);
foreach (var roadVehicle in roadVehicles)
{
    roadVehicle.Drive();
}

//3.
var watercrafts = new List<Watercraft>();
var sub = new Submarine();
watercrafts.Add(sub);
foreach (var watercraft in watercrafts)
{
    watercraft.Drive();
}