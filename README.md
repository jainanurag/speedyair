# speedyair
The application does the following:
1. Prints out Flight Scheudle for the 6 Flights (Hardcoded Objects)
2. Loads Order info from JSON (using NewtonSoft.Json Nuget Package)
3. Prints out Package Schedule with Flight Info



**Dependencies**

_Framework_
.Net 8 (VS 2022)

_Nuget Package(s)_
NewtonSoft v13.0.3

**Output**

User Story # 1
******************************************************
Flight:1, departure: YUL, arrival: YYZ, day: 1
Flight:2, departure: YUL, arrival: YYC, day: 1
Flight:3, departure: YUL, arrival: YVR, day: 1
Flight:4, departure: YUL, arrival: YYZ, day: 2
Flight:5, departure: YUL, arrival: YYC, day: 2
Flight:6, departure: YUL, arrival: YVR, day: 2
******************************************************
******************************************************
Package to Schedule Per Destination:34
Package to Schedule YYZ:34
Package to Schedule YYC:22
Package to Schedule YVR:37
Package to Schedule YER:3
******************************************************
User Story # 2
***************Package Schedule***********************
Order:order-001, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-002, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-003, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-004, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-005, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-006, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-007, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-008, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-009, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-010, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-011, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-012, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-013, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-014, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-015, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-016, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-017, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-018, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-019, flightNumber: 1, departure: YUL, arrival: YYZ, day: 1
Order:order-020, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-021, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-022, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-023, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-024, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-025, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-026, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-027, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-028, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-029, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-030, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-031, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-032, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-033, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-034, flightNumber: 4, departure: YUL, arrival: YYZ, day: 2
Order:order-035, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-036, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-037, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-038, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-039, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-040, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-041, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-042, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-043, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-044, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-045, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-046, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-047, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-048, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-050, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-052, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-054, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-055, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-056, flightNumber: 2, departure: YUL, arrival: YYC, day: 1
Order:order-057, flightNumber: 5, departure: YUL, arrival: YYC, day: 2
Order:order-060, flightNumber: 5, departure: YUL, arrival: YYC, day: 2
Order:order-061, flightNumber: 5, departure: YUL, arrival: YYC, day: 2
Order:order-062, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-063, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-064, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-065, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-066, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-067, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-068, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-069, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-070, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-071, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-072, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-073, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-074, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-075, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-076, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-077, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-078, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-080, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-081, flightNumber: 3, departure: YUL, arrival: YVR, day: 1
Order:order-082, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-083, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-084, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-085, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-086, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-087, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-088, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-089, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-090, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-091, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-092, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-093, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-094, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-095, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-096, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-097, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-098, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-099, flightNumber: 6, departure: YUL, arrival: YVR, day: 2
Order:order-049, flightNumber:not scheduled
Order:order-051, flightNumber:not scheduled
Order:order-053, flightNumber:not scheduled
*********************E N D*****************************
Press ENTER to EXIT
