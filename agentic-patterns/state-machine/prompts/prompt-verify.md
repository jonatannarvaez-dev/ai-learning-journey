# VERIFY State

A fix was applied. Your goal is to confirm it works.

## Steps

1. Re-run the same test case that failed
2. Compare output of `math_old.py` vs `math_new.py` for that function

## Output

- If results match → document the case in `cases/case-XXX.md` and move to [EXPLORE]
- If results still differ → report what's still wrong and move back to [DIAGNOSE]

## Case documentation format

```
# Case XXX
- Function: [name]
- Input: [values]
- Bug found: [description]
- Fix applied: [what changed]
- Result: PASS
```