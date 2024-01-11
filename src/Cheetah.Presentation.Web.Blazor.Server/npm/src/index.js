import $ from 'jquery';
import { ModuleManager } from 'igniteui-webcomponents-core';
import { IgcRadialGaugeCoreModule } from 'igniteui-webcomponents-gauges';
import { IgcRadialGaugeModule } from 'igniteui-webcomponents-gauges';
import { BpmnJS } from 'bpmn-js';


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
}

// the diagram to display
// you may load it asynchronously via ajax, too

var bpmnViewer = new BpmnJS({
    //container: '#canvas'
});


const bpmn =
    "<?xml version='1.0' encoding='UTF-8'?> " +
    "<bpmn:definitions xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:bpmn='http://www.omg.org/spec/BPMN/20100524/MODEL' xmlns:bpmndi='http://www.omg.org/spec/BPMN/20100524/DI' xmlns:dc='http://www.omg.org/spec/DD/20100524/DC' id='Definitions_03pouz8' targetNamespace='http://bpmn.io/schema/bpmn' exporter='bpmn-js (https://demo.bpmn.io)' exporterVersion='16.3.0'> " +
    "  <bpmn:process id='Process_0zntrix' isExecutable='false'> " +
    "    <bpmn:startEvent id='StartEvent_0pf72vj' /> " +
    "  </bpmn:process> " +
    "  <bpmndi:BPMNDiagram id='BPMNDiagram_1'> " +
    "    <bpmndi:BPMNPlane id='BPMNPlane_1' bpmnElement='Process_0zntrix'> " +
    "      <bpmndi:BPMNShape id='_BPMNShape_StartEvent_2' bpmnElement='StartEvent_0pf72vj'> " +
    "        <dc:Bounds x='156' y='82' width='36' height='36' /> " +
    "      </bpmndi:BPMNShape> " +
    "    </bpmndi:BPMNPlane> " +
    "  </bpmndi:BPMNDiagram> " +
    "</bpmn:definitions> ";



await bpmnViewer.importXML(bpmn);
// access viewer components
var canvas = bpmnViewer.get('#canvas');
