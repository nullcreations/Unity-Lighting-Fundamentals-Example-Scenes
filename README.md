# Unity Lighting Fundamentals Example Scenes

__EN__

Example Scenes made in Unity 2018.4.16 to showcase the lighting fundamentals learned by watching the Unite Europe 2017 and Unite Copenhagen 2019 talks and also by reading official documentation.

The scenes saved in the Scene Root Folder use the same Primitive Geometries (1 Static Sphere, 1 Moving Sphere, 2 modified Cubes as walls and a Plane).

__ES__

Escenas Ejemplo hechas en Unity 2018.4.16 para demostrar los fundamentos de iluminación aprendidos tras ver los talks Unite Europe 2017 y Unite Copenhagen 2019 y también tras leer documentación oficial.

Las escenas guardadas en la carpeta raiz Scene utilizan las mismas Geometrías Primitivas(1 Static Sphere, 1 Moving Sphere, 2 Cubes modificados como muros y un Plane).

## Default Lighting

![00_Default_Lighting](https://drive.google.com/uc?export=view&id=1h1ZnQO-kayrBYajmKuLfscTn6kAx-pSe)

__EN__

"00_Default_Lighting" has its Lighting Settings unaltered so it matches the dafault Unity settings and no object set as Lightmap Static. The Directional Light on the scene is set as RealTime.

__ES__

"00_Default_Lighting" tiene sus Lighting Settings inalterados para corresponder con los Unity settings por defecto y no hay ningún objeto marcado como Lightmap Static. La Directional Light en la escena está marcada como RealTime.


## RealTime Lighting (All Dynamic)

![00_RealTime_Lighting(AllDynamic)](https://drive.google.com/uc?export=view&id=1GvrpJ54Bg4nVYBE5Z2tInF0OSL2Gj4kE)

__EN__

"00_RealTime_Lighting(AllDynamic)" has its Lighting Settings set to RealTimeLighting only and no object set as Lightmap Static. The Directional Light on the scene is set as RealTime.

__ES__

"00_RealTime_Lighting(AllDynamic)" tiene sus Lighting Settings marcados como RealTimeLighting únicamente y no tiene objetos marcados como Lightmap Static. La Directional Light en la escena está marcada como RealTime.


## RealTime Lighting (with Static Objects)

![00_RealTime_Lighting(wStaticObjs)](https://drive.google.com/uc?export=view&id=12kVbgamI9_e_Bd4_jR4mE03mTLRMoKNF)

__EN__

"00_RealTime_Lighting(wStaticObjs)" has its Lighting Settings set to RealTimeLighting only and all the objects under the parent "Static Objects" set as Lightmap Static. The Directional Light on the scene is set as RealTime. Also RealTime Lightmaps were generated for the static objects.

__ES__

"00_RealTime_Lighting(wStaticObjs)" tiene sus Lighting Settings marcados como RealTimeLighting únicamente y todos los objetos bajo el parent "Static Objects" marcado como Lightmap Static. La Directional Light en la escena está marcada como RealTime. Así mismo, RealTime Lightmaps fueron generados para los objetos estáticos.

## Baked Lightmapping Enlighten

![01_Baked_Lightmapping_Enlighten](https://drive.google.com/uc?export=view&id=1aBHzBOk2NGFrCYa6gQsp0qh1T39mahbM)

__EN__

"01_Baked_Lightmapping_Enlighten" has its Lighting Settings set to MixedLighting only and all the objects under the parent "Static Objects" set as Lightmap Static. The Directional Light on the scene is set as Baked. Also Baked Lightmaps were generated for the static objects. The Enlighten lightmapper was used for this scene.

__ES__

"01_Baked_Lightmapping_Enlighten" tiene sus Lighting Settings marcados como MixedLighting únicamente y todos los objetos bajo el parent "Static Objects" marcado como Lightmap Static. La Directional Light en la escena está marcada como Baked. Así mismo, Baked Lightmaps fueron generados para los objetos estáticos. El Enlighten lightmapper fue utilizado para esta escena.

## Baked Lightmapping Progressive

![01_Baked_Lightmapping_Progressive](https://drive.google.com/uc?export=view&id=1rCvBAed1G1AX3RRWZcSxwZiMHbia_wHr)

__EN__

"01_Baked_Lightmapping_Progressive" has its Lighting Settings set to MixedLighting only and all the objects under the parent "Static Objects" set as Lightmap Static. The Directional Light on the scene is set as Baked. Also Baked Lightmaps were generated for the static objects. The Progressive lightmapper was used for this scene. Stitch Seams were set to true on the Static Sphere.

__ES__

"01_Baked_Lightmapping_Progressive" tiene sus Lighting Settings marcados como MixedLighting únicamente y todos los objetos bajo el parent "Static Objects" marcado como Lightmap Static. La Directional Light en la escena está marcada como Baked. Así mismo, Baked Lightmaps fueron generados para los objetos estáticos. El Progressive lightmapper fue utilizado para esta escena. Stitch Seams fueron usados en la Static Sphere.

## Mixed Lightmapping Enlighten

![02_Mixed_Lightmapping_Enlighten](https://drive.google.com/uc?export=view&id=1ki4XUvQFd1Yk3c-dUr9C5tvv7MQ8M3d2)

__EN__

"02_Mixed_Lightmapping_Enlighten" has its Lighting Settings set to MixedLighting only and all the objects under the parent "Static Objects" set as Lightmap Static. The Directional Light on the scene is set as Mixed. Also Baked Lightmaps were generated for the static objects. The Enlighten lightmapper was used for this scene. Notice that the Dynamic Sphere is now affected by the Directional light and casts and receives shadows.

__ES__

"02_Mixed_Lightmapping_Enlighten" tiene sus Lighting Settings marcados como MixedLighting únicamente y todos los objetos bajo el parent "Static Objects" marcado como Lightmap Static. La Directional Light en la escena está marcada como Mixed. Así mismo, Baked Lightmaps fueron generados para los objetos estáticos. El Enlighten lightmapper fue utilizado para esta escena. Notese que Dynamic Sphere es ahora afectado por Directional light y proyecta y recibe sombras.

## Mixed Lightmapping Progressive

![02_Mixed_Lightmapping_Progressive](https://drive.google.com/uc?export=view&id=1ae1sIrHriMcaRwjCcDLHgVIJF7qpxwTt)

__EN__

"02_Mixed_Lightmapping_Progressive" has its Lighting Settings set to MixedLighting only and all the objects under the parent "Static Objects" set as Lightmap Static. The Directional Light on the scene is set as Mixed. Also Baked Lightmaps were generated for the static objects. The Progressive lightmapper was used for this scene.  Stitch Seams were set to true on the Static Sphere. Notice that the Dynamic Sphere is now affected by the Directional light and casts and receives shadows.

__ES__

"02_Mixed_Lightmapping_Progressive" tiene sus Lighting Settings marcados como MixedLighting únicamente y todos los objetos bajo el parent "Static Objects" marcado como Lightmap Static. La Directional Light en la escena está marcada como Mixed. Así mismo, Baked Lightmaps fueron generados para los objetos estáticos. El Progressive lightmapper fue utilizado para esta escena. Stitch Seams fueron usados en la Static Sphere. Notese que Dynamic Sphere es ahora afectado por Directional light y proyecta y recibe sombras.

## 03 Mixed Lightmapping with Light Probs Progressive

![03_Mixed_Lightmapping_wLProbs_Progressive](https://drive.google.com/uc?export=view&id=18w-K3KoY3ACH7BJlUwKTL0Dp-aU0yJcF)

__EN__

"03_Mixed_Lightmapping_wLProbs_Progressive" has its Lighting Settings set to MixedLighting only and all the objects under the parent "Static Objects" set as Lightmap Static. The Directional Light on the scene is set as Mixed. Also Baked Lightmaps were generated for the static objects. The Progressive lightmapper was used for this scene.  Stitch Seams were set to true on the Static Sphere. Notice that the Dynamic Sphere is now affected by the Directional light and casts and receives shadows. The Light Probes added are positioned so the Dynamic Sphere receives some of the green "bleeding" from the Floor.

__ES__

"03_Mixed_Lightmapping_wLProbs_Progressive" tiene sus Lighting Settings marcados como MixedLighting únicamente y todos los objetos bajo el parent "Static Objects" marcado como Lightmap Static. La Directional Light en la escena está marcada como Mixed. Así mismo, Baked Lightmaps fueron generados para los objetos estáticos. El Progressive lightmapper fue utilizado para esta escena. Stitch Seams fueron usados en la Static Sphere. Notese que Dynamic Sphere es ahora afectado por Directional light y proyecta y recibe sombras. Las Light Probes añadidas son posicionadas de tal manera que Dynamic Sphere recibe un poco del "bleeding" verde del Piso.
