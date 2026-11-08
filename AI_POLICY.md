## How AI is used in ShareX-NVU

1. Every line created by AI MUST reach human eyes before a commit! Always review and test what it creates, as is expected with your own code.
2. No AI generated prose. AI should not create public-facing prose such as issues, READMEs, docs, other Markdown files, etc.
3. No AI-generated UI. All UI in ShareX-NVU MUST be hand-made, ideally via the Designer so others can later edit it easily.
   a. Rationale 1: AI generated UIs look bad and contributed to what ShareX 22 has become.
   b. Rationale 2: Agents typically have a hard time making sure what they create is compatiable with the designer in my experience. They often do stupid stuff like putting lambdas in .Designer.cs files which breaks them.
4. No AI-generated communication. Don't paste AI-generated output directly into issues, PRs, or any other form of discussions. AI is acceptable for translation but include the original untranslated text (perhaps in a [collapsed section](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections)).
5. Any usage of AI should be disclosed. This helps me better understand the context of the contribution. 
6. Quality. Pull requests will not be closed solely because they were made with AI, they will be closed if the quality is bad (i.e. slop).