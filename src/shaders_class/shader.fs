#version 330 core
out vec4 fragColor;

// excercise 3
// in vec3 ourColor;
in vec3 ourPosition;

void main()
{
    fragColor = vec4(ourPosition, 1.0f);
}