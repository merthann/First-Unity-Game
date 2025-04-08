using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(PlayerStats))]
public class PlayerStatsEditorü : Editor
{
    private PlayerStats StatsTarget => target as PlayerStats;


    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Reset Player"))
        {
            StatsTarget.ResetPlayer();
        }
    }
}
