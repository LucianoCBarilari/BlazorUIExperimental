# NestedTable Composite Demo

This component demonstrates hierarchical selection using the Composite pattern.

## Location
- `Components/NestedTable/MudTablesNested.razor`
- Models and helpers in `Components/NestedTable/`

## Purpose
- Parent (Organismo) selection is derived from child (Escalafon) selection.
- Selection is persisted as `(OrganismoID, EscalafonID)` pairs.

## Selection Rules
1. Selecting a parent selects all children.
2. Deselecting a parent deselects all children.
3. Deselecting the last child deselects the parent.
4. Selecting any child selects the parent.
5. Parent selection is derived: `IsSelected = Children.Any(c => c.IsSelected)`.

## UI Behavior
- Parent/child rows are rendered with nested `MudSimpleTable`.
- Parent rows can expand/collapse children.
- Header checkbox selects/deselects all.

## Data Flow
- Mock data lives in `CompositeMockData`.
- `CompositeFactory.BuildTree()` creates the in-memory tree.
- UI binds checkboxes to `IsSelected`.

## Persistence Output
- `GetSelectedAssignments()` returns the selected pairs in memory.
- These pairs are shown under the table for debugging.
