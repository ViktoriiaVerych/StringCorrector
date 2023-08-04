# Perhaps you ment ..?

In this project, our goal is to develop a straightforward system capable of detecting and rectifying spelling errors within words. The project is divided into two main segments: an initial foundational phase, which spans the first week and encompasses the initial two practical sessions, and the subsequent primary phase. Points can only be earned during the initial phase, serving as preparation, while the primary phase constitutes the core of the project.


## The following tasks were accomplished in this project:
1. Implementation of [Longest Common Subsequence](https://en.wikipedia.org/wiki/Longest_common_subsequence_problem) Algorithm:
   - The lecture content on the Longest Common Subsequence algorithm was thoroughly understood.
   - The algorithm was diligently reviewed, ensuring comprehension before embarking on the implementation phase.
   - The algorithm was coded from scratch without copying and pasting existing code.
   - For every "unknown" word, the top 5 potential candidates were determined using the implemented Longest Common Subsequence algorithm.
   - Instances were sought where utilizing this algorithm might yield incorrect suggestions, demonstrating a comprehensive understanding of its limitations.

2. Leveraging Edit Distance for Correction Options:
   - The concept of edit distance, quantifying the number of necessary modifications to transform one sequence into another, was studied in-depth.
   - The Levenshtein algorithm, which computes edit distance, was successfully implemented.
   - This algorithm now serves as a tool to gauge the similarity between sequences.
   - Each "unknown" word underwent a process of searching for potential correction options through edit distance analysis.
   - The outcomes of this analysis were presented to the user.

Moreover, an endeavor was made to accommodate permutations in the context of finding possible corrections. This enhances the scope of correction suggestions and increases accuracy in addressing typographical errors.



### The Levenshtein Algorithm
The Levenshtein algorithm, also known as the Levenshtein distance or edit distance algorithm, is a dynamic programming technique used to determine the minimum number of single-character edits (insertions, deletions, or substitutions) required to transform one string into another. It's often employed in various applications, including spell checking, DNA sequence alignment, and natural language processing. 

Here's a step-by-step explanation of how the Levenshtein algorithm works:

1. **Initialization**: Create a matrix where the rows correspond to the characters of the first string and the columns correspond to the characters of the second string. Initialize the first row and column with incremental values (0, 1, 2, ...).

2. **Filling the Matrix**:
   - Traverse through the matrix, starting from the second row and second column.
   - For each cell (i, j), calculate three values:
     - **Insertion**: The value from the cell directly above (i-1, j) plus 1.
     - **Deletion**: The value from the cell directly to the left (i, j-1) plus 1.
     - **Substitution**: The value from the diagonal cell (i-1, j-1) plus 1 if the characters at the current positions are not equal. If they are equal, no additional cost is added.
   - Assign the minimum of these three values to the current cell (i, j).

3. **Result**: The value in the last cell of the matrix (bottom-right corner) represents the Levenshtein distance between the two input strings. It indicates the minimum number of edits needed to transform one string into the other.

4. **Backtracking (Optional)**: To find the actual sequence of edits needed to transform one string into the other, you can backtrack through the matrix. Starting from the bottom-right cell, move to the neighboring cell with the smallest value, and repeat this process until you reach the top-left cell.

For example, if you want to transform the word "kitten" into "sitting," the Levenshtein distance is 3 (substituting 'k' with 's', 'e' with 'i', and appending 'g'). This algorithm provides a quantitative measure of the similarity or difference between two strings in terms of character-level edits.


### The Damerau-Levenshtein distance
The Damerau-Levenshtein distance is an extension of the Levenshtein distance algorithm that includes transposition of adjacent characters as a valid edit operation, in addition to insertion, deletion, and substitution. This inclusion of transpositions makes the Damerau-Levenshtein algorithm more suitable for certain applications where transposition errors are common, such as detecting typos involving swapped adjacent characters.

## Assignment 5 Description:
https://github.com/kse-ua/algorithms/blob/main/assignments_2023/assignment_5.md
