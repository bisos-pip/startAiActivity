#!/bin/bash -i
#

# Safety check: must run from a directory named "test" — the cleanup step
# rm -rf's AI-collaboration files, which would destroy real work if run
# from a non-test directory by mistake.
if [[ "$(basename "$PWD")" != "test" ]]; then
    echo "ERROR: verify.sh must be run from a directory named 'test'." >&2
    echo "  Current PWD: $PWD" >&2
    echo "  The initial cleanup step would delete AI-collaboration files." >&2
    exit 1
fi

# Start from a known-clean state (silent — matches may be absent)
lpDo eval rm -rf .claude AI-*.org CLAUDE.md AI-*.dormant CLAUDE.md.dormant 2\>/dev/null

lpDo ls -a -C -F

lpDo startAiActivity.cs -i userConfig_set --parName="templates" --parValue="/bisos/apps/defaults/ai-templates"           # BISOS DEFAULT
lpDo startAiActivity.cs -i userConfig_get --parName="templates"
lpDo startAiActivity.cs -i initiate --root="curDir" --activity="xu-single"           # Install xu-single templates into current directory
lpDo ls -a -C -F
lpDo startAiActivity.cs -i deClaudify           # Remove AI files from current directory
lpDo ls -a -C -F
lpDo startAiActivity.cs -i initiate --root="curDir" --activity="xu-single"           # Install xu-single templates into current directory
lpDo ls -a -C -F
lpDo startAiActivity.cs -i aiSuspend
lpDo ls -a -C -F
lpDo startAiActivity.cs -i aiResume
lpDo ls -a -C -F
lpDo startAiActivity.cs -i deClaudify           # Remove AI files from current directory
lpDo ls -a -C -F
lpDo startAiActivity.cs -i initiateSub --activity="xu-single"
lpDo ls -a -C -F
lpDo startAiActivity.cs -i deClaudify           # Remove AI files from current directory
lpDo ls -a -C -F

# Negative-case tests for initiateSub — should refuse cleanly.
# 1. No initiated parent: run in a fresh /tmp dir outside the BISOS tree.
TMPDIR=$(mktemp -d)
lpDo pushd "$TMPDIR"
lpDo ls -a -C -F
lpDo startAiActivity.cs -i initiateSub --activity="xu-single"           # EXPECT REFUSAL: No initiated parent found
lpDo ls -a -C -F
lpDo popd
lpDo eval rm -rf "$TMPDIR"
