# CLAUDE.md — Agent Context

## Project
This is a state machine agent example for testing and auto-correcting a Python implementation.

## Goal
Find differences between `math_old.py` (reference) and `math_new.py` (new implementation), then fix the bugs in `math_new.py` until both produce identical results.

## Files
- `math_old.py` — reference implementation, always correct, never modify
- `math_new.py` — new implementation, may contain bugs, this is the file to fix
- `prompts/` — specialized prompts for each agent state
- `cases/` — document findings here

## Rules
- NEVER modify `math_old.py`
- Only modify `math_new.py` to fix bugs
- After each fix, re-run the comparison to verify
- Document each case found in `cases/`

## Language
Respond and document everything in English.
