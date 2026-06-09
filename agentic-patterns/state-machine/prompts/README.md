# State Machine Agent — Example

A self-correcting agent that finds bugs, fixes them, and verifies the fix autonomously.

This is a small-scale example of the **agentic state machine pattern** — built to validate the architecture before applying it to real production cases.

---

## What it does

1. **Explores** — compares two implementations function by function
2. **Diagnoses** — identifies exactly what is wrong and why
3. **Fixes** — applies the minimal correction needed
4. **Verifies** — confirms the fix works, then continues to the next case

The agent iterates until all cases pass or it finds something it cannot resolve.

---

## Files

```
state-machine/
├── CLAUDE.md              ← context for the agent
├── math_old.py            ← reference implementation (correct, never modify)
├── math_new.py            ← new implementation (contains bugs)
├── prompts/
│   ├── orchestrator.md    ← main prompt with state machine logic
│   ├── prompt-explore.md  ← finds differences
│   ├── prompt-diagnose.md ← analyzes the bug
│   ├── prompt-fix.md      ← corrects the file
│   └── prompt-verify.md   ← confirms the fix
└── cases/                 ← agent documents each finding here
```

---

## How to run

Open Claude Code in VS Code and type:

```
Follow the instructions in prompts/orchestrator.md and start the process.
```

Claude Code will read `CLAUDE.md` automatically as context and execute the full cycle.

---

## State machine diagram

```
[EXPLORE] → difference found → [DIAGNOSE] → bug identified → [FIX] → fix applied → [VERIFY]
    ↑                                                                          |
    |_________________________ case passes ____________________________________|
                                                                     |
                                                         case fails → [DIAGNOSE]
```

---

## Why this pattern matters

Most agentic systems fail because of one long, complex prompt that loses focus mid-execution.

This pattern solves that by:
- Keeping each prompt small and focused on one responsibility
- Making the agent state explicit at all times
- Enabling easy debugging — you always know which state failed

This same architecture scales directly to multi-agent systems (Semantic Kernel, LangGraph) where each state becomes an independent agent.

---

## Real world application

This example uses simple math functions. The same pattern applies to:
- Comparing legacy vs new C# transformation outputs
- Validating API response migrations
- Any scenario where two implementations should produce identical results

---

*Part of [ai-learning-journey](https://github.com/jonatannarvaez-dev/ai-learning-journey) — documenting my path from C# developer to AI Engineer.*