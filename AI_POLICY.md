# How AI is used in ShareX-NVU

## AI helps us:

1. Automate simple but tedious things, such as the nested-class link change in [7e59785](https://github.com/Gameknight963/ShareX-NoVibecodedUi/commit/7e5978566420f6a1815db2339078ded81871f9e0)
2. Cherry-pick changes from upstream, provided a human reviews them
3. Write backend code that is not visible to the user, provided the quality is good, reviewed, and tested

## ...but it does not:

1. Write entire refactors for us without testing, review, or human input
2. Create any form of prose. AI should not create public-facing prose such as issues, READMEs, docs, other Markdown files, etc.
3. Create UI. All UI in ShareX-NVU MUST be hand-made, ideally via the Designer so others can later edit it easily. _This excludes cases which would involve a lot of tedious low-skilled work, in which case AI can be a good tool._

   a. Rationale 1: AI generated UIs look bad and contributed to what ShareX 22 has become.
   
   b. Rationale 2: Agents typically have a hard time making sure what they create is compatiable with the designer in my experience. They often do stupid stuff like putting lambdas in .Designer.cs files which breaks them.
5. Speak for us. No AI-generated communication. Don't paste AI-generated output directly into issues, PRs, or any other form of discussions. AI is acceptable for translation but include the original untranslated text (perhaps in a [collapsed section](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections)).

## ...and it is not:

1. Used undisclosed.  Any usage of AI should be disclosed. All I ask for is one sentence, such as the one in the README. You are of course welcome to write more.
2. An excuse to write low-quality code. AI-generated pull requests will be held to the same standards as others. Pull requests will not be closed solely because they were made with AI, they will be closed if the quality is bad (i.e. slop).
