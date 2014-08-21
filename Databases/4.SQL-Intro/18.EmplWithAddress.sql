SELECT
	FirstName, LastName, t.Name, a.AddressText
FROM
	Employees as e
		JOIN Addresses as a
			ON e.AddressID = a.AddressID
		JOIN Towns as t
			ON a.TownID = t.TownID