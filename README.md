"# APBD-Task1" 
Task 5 note - Separate commit before merging
Task 5 explanation - Merge was not fast forward because before merge there was a commit for main and feature-max. Git had to create merge commit to combine both histories
Task 6 note - Separate commit added on main before rebasing
Task 6 explanation - Merge preservers branch structure and create a merge commit. Rebase rewrite branch commits on top of updated main branch. Its more cleaner and more linear history
Task 7 explanation - Conflict was resolved manually. I combined variable name from main with output message from feature-conflict and updated the code.


### 1. When does Git perform a fast-forward and when is a merge commit created?
Git performs a fast-forward when target branch has no new commits after the branch was created so the branch pointer can simply move forward.
Merge commit is created when both branches have new commits and Git have to combine two separate histories.

### 2. What is the practical difference between merge and rebase?
Merge keeps the branch structure and creates a merge commit.
Rebase rewrites feature branch commits on top of updated main branch which creates cleaner and more linear history.

### 3. How was the conflict resolved in the repository?
The conflict was resolved manually.
I combined the variable name from main with the output message from feature-conflict and updated the code so that both CalculateMax and CalculateMin use the same array variable.
