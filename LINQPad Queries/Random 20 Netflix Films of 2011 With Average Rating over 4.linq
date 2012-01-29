<Query Kind="Expression">
  <Connection>
    <ID>7ed25e53-c62e-4604-9aa8-cfb790f7f1e9</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://odata.netflix.com/Catalog/</Server>
  </Connection>
</Query>

//This is an example of Fluent LINQ syntax
Titles
	.Where (t => t.ReleaseYear == 2011)
	.Where (t => t.AverageRating > 4)
	.OrderByDescending(t => t.AverageRating)
	.Take(20)