SELECT
	FirstName, LastName, t.Name, a.AddressText
FROM
	Employees AS e,
	Addresses AS a,
	Towns AS t
WHERE e.AddressID = a.AddressID AND a.TownID = t.TownID