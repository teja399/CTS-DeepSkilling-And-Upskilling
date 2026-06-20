SELECT DISTINCT
    u.user_id,
    u.full_name,
    u.email
FROM Users u
JOIN Registrations r
    ON u.user_id = r.user_id;
