# EXPLORE State

Your goal is to find a function that produces different results between `math_old.py` and `math_new.py`.

## Steps

1. Write a small Python script that imports both files and tests each function with these cases:
   - add(3, 2), subtract(10, 4), multiply(3, 5), divide(10, 2), power(2, 8)
2. Run the script
3. Compare outputs side by side

## Output

- If all results match → report "ALL CASES PASS" and stop
- If a difference is found → report:
  - Function name
  - Input used
  - Expected output (from math_old.py)
  - Actual output (from math_new.py)
  - Move to state [DIAGNOSE]
