# CMakeList.txt : projet CMake pour TP4, incluez la source et définissez
# la logique spécifique au projet ici.
#
cmake_minimum_required (VERSION 3.8)

project ("TP4")

# Current directory is ray_sphere_tp2
set(glm_DIR ../librairies/glm/cmake/glm)
find_package(glm REQUIRED )

set(SFML_STATIC_LIBRARIES TRUE)
set(SFML_DIR ../librairies/SFML-2.5.1/lib/cmake/SFML)
find_package(SFML 2.5.1 COMPONENTS graphics window REQUIRED)

# Ajoutez une source à l'exécutable de ce projet.
#add_executable (TP4 "TP4.cpp" "TP4.h")
add_executable (TP4 "TP4.cpp" "TP4.h"  "Ray.h"  "SceneObject.h" "Sphere.h"   "Light.h" "Scene.h" "Scene.cpp" "Camera.h" "Sphere.cpp" "Camera.cpp" )

target_link_libraries(${PROJECT_NAME} glm::glm)
target_link_libraries(${PROJECT_NAME} sfml-graphics sfml-window)
# TODO: Ajoutez des tests et installez des cibles si nécessaire.
