﻿import $ from 'jquery';
import { ModuleManager } from 'igniteui-webcomponents-core';
import { IgcRadialGaugeCoreModule } from 'igniteui-webcomponents-gauges';
import { IgcRadialGaugeModule } from 'igniteui-webcomponents-gauges';
import BpmnJS from 'bpmn-js/lib/Modeler';

//const MiniCssExtractPlugin = require("mini-css-extract-plugin");   
import diagram_js from 'bpmn-js/dist/assets/diagram-js.css';
import bpmn_js from 'bpmn-js/dist/assets/bpmn-js.css';
import bpmn from 'bpmn-js/dist/assets/bpmn-font/css/bpmn.css';
import bpmn_embedded from 'bpmn-js/dist/assets/bpmn-font/css/bpmn-embedded.css';

$('.step-menu li').click(function () {
    $('.current').removeClass('current')
    $('.complete').removeClass('complete')
    $(this).addClass('current')
    $(this).prevAll().addClass('complete')
})

// Module Manager for registering the modules of the chart


// register the modules
ModuleManager.register(
    IgcRadialGaugeCoreModule,
    IgcRadialGaugeModule
);
window.updateValue = function (value) {
    var rg = document.getElementById("rg");
    rg.value = value;    
    try {
        var bpmnJS = new BpmnJS({
            container: '#canvas'
        });
        const bpmn =
            "<?xml version='1.0' encoding='UTF-8'?> " +
            "<definitions xmlns='http://www.omg.org/spec/BPMN/20100524/MODEL' xmlns:bpmndi='http://www.omg.org/spec/BPMN/20100524/DI' xmlns:omgdi='http://www.omg.org/spec/DD/20100524/DI' xmlns:omgdc='http://www.omg.org/spec/DD/20100524/DC' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' id='sid-38422fae-e03e-43a3-bef4-bd33b32041b2' targetNamespace='http://bpmn.io/bpmn' exporter='bpmn-js (https://demo.bpmn.io)' exporterVersion='16.3.2'> " +
            "  <process id='Process_1' isExecutable='false'> " +
            "    <startEvent id='StartEvent_1y45yut' name='hunger noticed'> " +
            "      <outgoing>SequenceFlow_0h21x7r</outgoing> " +
            "    </startEvent> " +

            "    <task id='Task_1hcentk' name='choose recipe'> " +
            "      <incoming>SequenceFlow_0h21x7r</incoming> " +
            "      <outgoing>SequenceFlow_0wnb4ke</outgoing> " +
            "    </task> " +

            "    <sequenceFlow id='SequenceFlow_0h21x7r' sourceRef='StartEvent_1y45yut' targetRef='Task_1hcentk' /> " +

            "    <exclusiveGateway id='ExclusiveGateway_15hu1pt' name='desired dish?'> " +
            "      <incoming>SequenceFlow_0wnb4ke</incoming> " +
            "    </exclusiveGateway> " +

            "    <sequenceFlow id='SequenceFlow_0wnb4ke' sourceRef='Task_1hcentk' targetRef='ExclusiveGateway_15hu1pt' /> " +
            "  </process> " +
            "  <bpmndi:BPMNDiagram id='BpmnDiagram_1'> " +
            "    <bpmndi:BPMNPlane id='BpmnPlane_1' bpmnElement='Process_1'> " +
            "      <bpmndi:BPMNShape id='StartEvent_1y45yut_di' bpmnElement='StartEvent_1y45yut'> " +
            "        <omgdc:Bounds x='152' y='102' width='36' height='36' /> " +
            "        <bpmndi:BPMNLabel> " +
            "          <omgdc:Bounds x='134' y='145' width='73' height='14' /> " +
            "        </bpmndi:BPMNLabel> " +
            "      </bpmndi:BPMNShape> " +
            "      <bpmndi:BPMNShape id='Task_1hcentk_di' bpmnElement='Task_1hcentk'> " +
            "        <omgdc:Bounds x='240' y='80' width='100' height='80' /> " +
            "      </bpmndi:BPMNShape> " +
            "      <bpmndi:BPMNShape id='ExclusiveGateway_15hu1pt_di' bpmnElement='ExclusiveGateway_15hu1pt' isMarkerVisible='true' bioc:stroke='#5b176d' bioc:fill='#e1bee7' color:background-color='#e1bee7' color:border-color='#5b176d'> " +
            "        <omgdc:Bounds x='395' y='95' width='50' height='50' /> " +
            "        <bpmndi:BPMNLabel> " +
            "          <omgdc:Bounds x='388' y='152' width='65' height='14' /> " +
            "        </bpmndi:BPMNLabel> " +
            "      </bpmndi:BPMNShape> " +
            "      <bpmndi:BPMNEdge id='SequenceFlow_0h21x7r_di' bpmnElement='SequenceFlow_0h21x7r'> " +
            "        <omgdi:waypoint x='188' y='120' /> " +
            "        <omgdi:waypoint x='240' y='120' /> " +
            "      </bpmndi:BPMNEdge> " +
            "      <bpmndi:BPMNEdge id='SequenceFlow_0wnb4ke_di' bpmnElement='SequenceFlow_0wnb4ke'> " +
            "        <omgdi:waypoint x='340' y='120' /> " +
            "        <omgdi:waypoint x='395' y='120' /> " +
            "      </bpmndi:BPMNEdge> " +
            "    </bpmndi:BPMNPlane> " +
            "  </bpmndi:BPMNDiagram> " +
            "</definitions> ";
        const result = bpmnJS.importXML(bpmn);
        const { warnings } = result;
        console.log(warnings);
    } catch (err) {
        console.log(err.message, err.warnings);
    }
}

// the diagram to display
// you may load it asynchronously via ajax, too

//var bpmnViewer = new BpmnJS({
//    container: '#canvas'
//});