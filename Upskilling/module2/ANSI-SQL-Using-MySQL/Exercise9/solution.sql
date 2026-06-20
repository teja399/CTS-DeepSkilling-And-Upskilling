SELECT
    e.event_id,
    e.title,
    COUNT(f.feedback_id) AS feedback_count
FROM Events e
LEFT JOIN Feedback f
    ON e.event_id = f.event_id
GROUP BY e.event_id, e.title
ORDER BY feedback_count DESC;
