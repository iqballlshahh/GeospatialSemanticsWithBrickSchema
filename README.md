Steps:
1) Download and install the Unity asset from https://assetstore.unity.com/packages/tools/modeling/geospatial-semantics-brickschema-integration-280102 (this unlocks features a and b below)
2) Download both exe files and .cs files from this git repo and place it into your Unity project's Assets folder to unlock features (c and d)


BACKGROUND:
Supporting Tool used in our Recent Study (under-review):
A automated approach for developing geospatial semantic Digital Twins (DTs), aimed at addressing the manual-intensive scripting of semantics

This study introduces an automated approach for developing geospatial semantic Digital Twins (DTs), aimed at addressing the manual-intensive scripting of semantics, User Interface (UI) controllers, and integration with real-world actuators. By harnessing geospatial information through the “Geospatial Semantics-BrickSchema Integration” tool developed for this research, it presents an automated pathway for geospatial semantic DT development, highlighting its potential as a high-level semantic to integrate existing building ontologies such as BrickSchema.
a) The geospatial extraction process would commence by clicking on the “Export to CSV” feature within the developed package (output file would be placed at the Assets folder, do not move it to other folders if you wish to later use features c and d)
b) The “Attach BrickSchema Component” button that this study has developed,would attach a BrickSchema Component to every object within the Unity scene
c) "Simple RDF Visualizer" generates a html file which visualizes the exported geospatial embedded CSV in a RDF graph
d) The button “BrickSchema-Automate Generate” could then be used to automatically reformat the information into a Brick Generate.py format with all the entity names, brick class and appropriate edges/relationship being generated.

INSTRUCTIONS:
1) If you came from the Unity Asset Store, download both the exe files in this repository and place it in your unity project's /Assets Folder and everything is good to go (all buttons would work)
2) Else, you can download the unity package file in this repo, and import it into your Unity Project
3) This asset can be found in the Unity Asset Store named "Geospatial Semantics-BrickSchema Integration"

Also, do visit https://assetstore.unity.com/packages/tools/modeling/geospatial-semantics-brickschema-integration-280102 as the BrickSchema stuff we incorporated builds upon their work
