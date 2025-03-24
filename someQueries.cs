// PSQL
// SELECT 
//     "t"."Id" AS "TeamId",
//     "t"."Name" AS "TeamName",
//     COALESCE(SUM("dr"."Points"), 0) AS "TotalPoints",
//     RANK() OVER (ORDER BY COALESCE(SUM("dr"."Points"), 0) DESC) AS "Ranking"
// FROM public."Teams" AS "t"
// LEFT JOIN public."Drivers" AS "d" ON "t"."Id" = "d"."TeamId"
// LEFT JOIN public."DriverRaces" AS "dr" ON "d"."Id" = "dr"."DriverId"
// GROUP BY "t"."Id", "t"."Name"
// ORDER BY "TotalPoints" DESC;

//Entity queries
// var teamRankings = await _context.Teams
//     .Select(t => new
//     {
//         TeamId = t.Id,
//         TeamName = t.Name,
//         TotalPoints = t.Drivers
//             .SelectMany(d => d.DriverRaces)
//             .Sum(dr => (int?)dr.Points) ?? 0
//     })
//     .OrderByDescending(t => t.TotalPoints)
//     .Select((t, index) => new
//     {
//         t.TeamId,
//         t.TeamName,
//         t.TotalPoints,
//         Ranking = index + 1
//     })
//     .ToListAsync();
