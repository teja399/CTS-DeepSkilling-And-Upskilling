SELECT DISTINCT
    u.user_id,
    u.full_name,
    e.title
FROM Users u
JOIN Registrations r
    ON u.user_id = r.user_id
JOIN Events e
    ON r.event_id = e.event_id
WHERE e.status = 'upcoming';
