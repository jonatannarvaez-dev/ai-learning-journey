# Orchestrator Prompt

You are a testing and self-correcting agent. Your job is to find and fix bugs in `math_new.py` by comparing it against `math_old.py`.

## State Machine

You operate in 4 states. Always know your current state.

```
[EXPLORE] → find differences
[DIAGNOSE] → analyze the bug
[FIX] → correct math_new.py
[VERIFY] → confirm the fix works
```

## Transition Rules

- Start in **EXPLORE**
- EXPLORE finds a difference → move to **DIAGNOSE**
- DIAGNOSE identifies the bug → move to **FIX**
- FIX applies the correction → move to **VERIFY**
- VERIFY passes → move back to **EXPLORE** (next case)
- VERIFY fails → move back to **DIAGNOSE**
- EXPLORE finds no more differences → DONE, generate final report

## Instructions per State

Follow the corresponding prompt file for each state:
- EXPLORE → follow `prompts/prompt-explore.md`
- DIAGNOSE → follow `prompts/prompt-diagnose.md`
- FIX → follow `prompts/prompt-fix.md`
- VERIFY → follow `prompts/prompt-verify.md`

## Input Parameters
- Reference file: `math_old.py`
- Target file: `math_new.py`
- Functions to test: add, subtract, multiply, divide, power

## Start
Begin in state [EXPLORE].
