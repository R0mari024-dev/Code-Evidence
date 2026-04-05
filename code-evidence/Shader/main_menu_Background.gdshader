shader_type canvas_item;

uniform vec3 text_color : source_color = vec3(0.0, 1.0, 0.0);
uniform float speed : hint_range(0.0, 5.0) = 10;
uniform float blur_amount : hint_range(0.0, 0.05) = 0.02; // Параметр размытия

float random(float x) {
    return fract(sin(x) * 43758.5453);
}

float matrix_column(vec2 uv, float columns) {
    float x = floor(uv.x * columns);
    float rand_x = random(x);
    float y = fract(uv.y - TIME * speed * (0.5 + rand_x) + rand_x * 10.0);
    float brightness = pow(y, 3.0);
    float char_selection = step(0.9, random(floor(uv.y * 20.0) + floor(TIME * 15.0)));
    return brightness * char_selection;
}

void fragment() {
    float columns = 50.0;
    
    // Основной слой
    float color = matrix_column(UV, columns);
    
    // Добавляем "блюр" за счет наложения сдвинутых копий
    color += matrix_column(UV + vec2(blur_amount, 0.0), columns) * 0.3;
    color += matrix_column(UV - vec2(blur_amount, 0.0), columns) * 0.3;
    
    COLOR = vec4(text_color * color, 1.0);
}
