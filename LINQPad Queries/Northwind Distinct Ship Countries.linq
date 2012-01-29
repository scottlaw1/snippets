<Query Kind="Statements">
  <Connection>
    <ID>896a64d8-7f10-47ec-b0b7-8687201259df</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

var countries = (from o in Orders select o.ShipCountry).Distinct();

countries.OrderBy(c => c).Dump();
