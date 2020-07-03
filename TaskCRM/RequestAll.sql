SELECT dbo.country.name AS 'Country', 
	   dbo.country.code AS 'Code', 
	   capital.name AS 'Capital', 
	   dbo.country.area AS 'Area',
	   dbo.country.population AS 'Population',
	   region.name as 'Region'
FROM dbo.country 
INNER JOIN dbo.city capital ON dbo.country.capital_id = capital.id
INNER JOIN dbo.region region ON dbo.country.region_id = region.id