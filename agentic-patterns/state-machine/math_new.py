# math_new.py — New implementation (contains bugs for the agent to find and fix)

def add(a, b):
    return a + b

def subtract(a, b):
    return a - b  # Bug: should be a - b

def multiply(a, b):
    return a * b

def divide(a, b):
    if b == 0:
        raise ValueError("Division by zero")
    return a / b

def power(a, b):
    return a ** b
