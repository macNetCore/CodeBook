import QtQuick 2.9
import QtQuick.Layouts 1.3
import QtQuick.Controls 2.3

ApplicationWindow {
    id: window
    width: 500
    height: 300
    visible: true
    

	maximumHeight: height
	minimumHeight: height
    maximumWidth: width
	minimumWidth: width
	
	title: "QML.photoshopForm"



    property bool spinning: false


//Item {
//    width:500
//    height:300


    Image {
        id: bkg
        source: "images/bkg.png"
        x: 0
        y: 0
        opacity: 1
    }

    //Button
    Image {
        id: b
        source: "images/b.png"
        x: 0
        y: 0
        opacity: 1
    }

    MouseArea {
       anchors.fill: b

       onClicked:{
           
		   if (spinning===false){
				spinning = true
				hov.opacity = 1
			}
		 
		   if (start.text === "stop" && spinning===true){
				spinning = false
				hov.opacity = 0
			}

			if (spinning===false){
				start.text = "start"
			}

			if (spinning===true){
				start.text = "stop"
			}
       }

    }

    Image {
        id: hov
        source: "images/hov.png"
        x: 0
        y: 0
        opacity: 0
    }
    Image {
        id: active
        source: "images/active.png"
        x: 0
        y: 0
        opacity: 0
    }
    //End Button

    Text {
        id: start
        text: qsTr("Start")
        font.pixelSize: 10
        font.family: "Arial-BoldMT"
        font.bold: true
        color: "#8fb0ff"
        smooth: true
        x: 237
        y: 253.5
        opacity: 1
    }

    Image {
        id: polygon_bg
        source: "images/polygon_bg.png"
        x: 0
        y: 0
        opacity: 0.50
        anchors.centerIn: window

        RotationAnimation on rotation{
            from: 0
            to: -360
            duration: 3000
            running: true
            loops: Animation.Infinite
        }
    }
    Image {

        id: polygon_bg_copy
        source: "images/polygon_bg_copy.png"
        x: 0
        y: 0
        opacity: 0.27
        anchors.centerIn: window

        RotationAnimation on rotation{
            from: 0
            to: 360
            duration: 3000
            running: true
            loops: Animation.Infinite
        }
    }

    //Center
    Image {
        id: polygon_1
        anchors.centerIn: Window
        source: "images/polygon_1.png"
        x: 0
        y: 0
        opacity: 0.50

        RotationAnimation on rotation{
            from: 0
            to: 360
            duration: 2000
            running: spinning
            loops: Animation.Infinite
        }
    }
    Image {
        id: polygon_1_copy
        source: "images/polygon_1_copy.png"
        x: 0
        y: 0
        opacity: 1
        anchors.centerIn: Window

        RotationAnimation on rotation{
            from: 0
            to: -360
            duration: 2500
            running: spinning
            loops: Animation.Infinite
        }

    }
    Text {
        id: percentNumber
        text: qsTr("100%")
        font.pixelSize: 30
        font.family: "Arial-BoldMT"
        font.bold: true
        color: "#8fb0fd"
        smooth: true
        x: 211
        y: 91.5
        opacity: 1
    }
    //end Center

    Image {
        id: lens
        source: "images/lens.png"
        x: 0
        y: 0
        opacity: 0

    }
}
