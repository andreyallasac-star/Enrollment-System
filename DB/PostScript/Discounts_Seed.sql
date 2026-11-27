INSERT INTO Discounts (DiscountName, DiscountPercent, IsActive)
SELECT v.DiscountName, v.DiscountPercent, v.IsActive
FROM (VALUES
    ('None', 0.00, 1),
    ('Sibling Discount', 10.00, 1),
    ('Honor Student (With Honors)', 15.00, 1),
    ('Honor Student (With High Honors)', 25.00, 1),
    ('Academic Scholar', 50.00, 1),
    ('Full Scholar', 100.00, 1)
) AS v(DiscountName, DiscountPercent, IsActive)
WHERE NOT EXISTS (
    SELECT 1 FROM Discounts d WHERE d.DiscountName = v.DiscountName
);