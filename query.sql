select p.Name, c.Name from Product p 
left join ProductCategory pc on p.Id = pc.ProductId 
left join Category c on pc.CategoryId = c.Id