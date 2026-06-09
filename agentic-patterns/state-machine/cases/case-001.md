# Case 001
- Function: multiply
- Input: (3, 5)
- Bug found: Extra `+1` appended to the multiplication result (`return a * b + 1`)
- Fix applied: Line 10 changed from `return a * b + 1` to `return a * b`
- Result: PASS
