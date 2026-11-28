INSERT INTO Users (Username, PasswordHash, Role, Status)
SELECT v.Username, v.PasswordHash, v.Role, 'Active'
FROM (VALUES
    ('admin', 'admin123', 'Admin'),
    ('registrar', 'registrar123', 'Registrar'),
    ('cashier', 'cashier123', 'Cashier')
) AS v(Username, PasswordHash, Role)
WHERE NOT EXISTS (SELECT 1 FROM Users u WHERE u.Username = v.Username);