using UnityEngine;
using UnityEngine.UIElements;

public sealed class Monitor : MonoBehaviour
{
    Label _systemText;
    Label _inputText;
    Label _outputText;

    MidiSystemTest _systemTest;
    MidiInTest _inputTest;
    MidiOutTest _outputTest;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        _systemText = root.Q<Label>("system-text");
        _inputText = root.Q<Label>("input-text");
        _outputText = root.Q<Label>("output-text");

        _systemTest = FindFirstObjectByType<MidiSystemTest>();
        _inputTest = FindFirstObjectByType<MidiInTest>();
        _outputTest = FindFirstObjectByType<MidiOutTest>();
    }

    void Update()
    {
        if (_systemTest != null)
            _systemText.text = _systemTest.InfoText;

        if (_inputTest != null)
            _inputText.text = _inputTest.InfoText;

        if (_outputTest != null)
            _outputText.text = _outputTest.InfoText;
    }
}
