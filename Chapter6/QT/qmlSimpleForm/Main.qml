import QtQuick 2.9
import QtQuick.Layouts 1.3
import QtQuick.Controls 2.3
import QtQuick.Controls.Universal 2.3
//import Mini 1.0

ApplicationWindow {
    id: window
    width: 480
    height: 320
    visible: true
    title: "qmlSimpleForm"


    Universal.theme: Universal.Dark
    Universal.accent: '#76608A'


    Shortcut {
        sequences: ["Esc", "Back"]
        enabled: stackView.depth > 1
        onActivated: {
            stackView.pop()
            listView.currentIndex = -1
        }
    }


    StackView {
        id: stackView
        anchors.bottomMargin: 130
        anchors.fill: parent

        initialItem: Pane {
            id: pane

            Label {
                id:labeltext
                x: 172
                y: 152
                text: "Hello QML.NET world !"

                horizontalAlignment: Label.AlignHCenter
                verticalAlignment: Label.AlignVCenter
                wrapMode: Label.Wrap
            }

             Button {
                id: button1
                anchors.margins: 20
                anchors.right: parent.right
                anchors.bottom: parent.bottom
                text: qsTr(" Click with QML ")
                onClicked: {
                    labeltext.text = "Clicked from QML"
                }
              }

             Button {
                   id: button2
                   anchors.margins: 20
                   anchors.left: parent.left
                   anchors.bottom: parent.bottom
                   text: qsTr(" Click with .NET ")
                   onClicked: {
                       //Todo call click .NET
                       labeltext.text = model.buttonNET_clicked()
                   }
              }

             MinimalModel {
                 id: model
              }
        }
    }
}
