#pragma once

#include "ChromaSDKPluginTypes.h"

/* Setup log mechanism */
typedef void(*DebugLogPtr)(const char*);
void LogDebug(const char* text, ...);
void LogError(const char* text, ...);
/* End of setup log mechanism */
                
#pragma region API typedefs
/*
	Return the sum of colors
*/
typedef int			(*PLUGIN_ADD_COLOR)(const int color1, const int color2);
/*
	Adds a frame to the `Chroma` animation and sets the `duration` (in seconds). 
	The `color` is expected to be an array of the dimensions for the `deviceType/device`. 
	The `length` parameter is the size of the `color` array. For `EChromaSDKDevice1DEnum` 
	the array size should be `MAX LEDS`. For `EChromaSDKDevice2DEnum` the array 
	size should be `MAX ROW` times `MAX COLUMN`. Returns the animation id upon 
	success. Returns negative one upon failure.
*/
typedef int			(*PLUGIN_ADD_FRAME)(int animationId, float duration, int* colors, int length);
/*
	Add source color to target where color is not black for frame id, reference 
	source and target by id.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS)(int sourceAnimationId, int targetAnimationId, int frameId);
/*
	Add source color to target where color is not black for all frames, reference 
	source and target by id.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Add source color to target where color is not black for all frames, reference 
	source and target by name.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Add source color to target where color is not black for all frames starting 
	at offset for the length of the source, reference source and target by 
	id.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET)(int sourceAnimationId, int targetAnimationId, int offset);
/*
	Add source color to target where color is not black for all frames starting 
	at offset for the length of the source, reference source and target by 
	name.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double offset);
/*
	Add source color to target where color is not black for frame id, reference 
	source and target by name.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId);
/*
	Add source color to target where color is not black for the source frame 
	and target offset frame, reference source and target by id.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_OFFSET)(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
/*
	Add source color to target where color is not black for the source frame 
	and target offset frame, reference source and target by name.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_ADD_NON_ZERO_ALL_KEYS_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
/*
	Add source color to target where the target color is not black for all frames, 
	reference source and target by id.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Add source color to target where the target color is not black for all frames, 
	reference source and target by name.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Add source color to target where the target color is not black for all frames 
	starting at offset for the length of the source, reference source and target 
	by id.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_OFFSET)(int sourceAnimationId, int targetAnimationId, int offset);
/*
	Add source color to target where the target color is not black for all frames 
	starting at offset for the length of the source, reference source and target 
	by name.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double offset);
/*
	Add source color to target where target color is not blank from the source 
	frame to the target offset frame, reference source and target by id.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_OFFSET)(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
/*
	Add source color to target where target color is not blank from the source 
	frame to the target offset frame, reference source and target by name.
*/
typedef void		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_ADD_NON_ZERO_TARGET_ALL_KEYS_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
/*
	Append all source frames to the target animation, reference source and target 
	by id.
*/
typedef void		(*PLUGIN_APPEND_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Append all source frames to the target animation, reference source and target 
	by name.
*/
typedef void		(*PLUGIN_APPEND_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_APPEND_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	`PluginClearAll` will issue a `CLEAR` effect for all devices.
*/
typedef void		(*PLUGIN_CLEAR_ALL)();
/*
	`PluginClearAnimationType` will issue a `CLEAR` effect for the given device.
*/
typedef void		(*PLUGIN_CLEAR_ANIMATION_TYPE)(int deviceType, int device);
/*
	`PluginCloseAll` closes all open animations so they can be reloaded from 
	disk. The set of animations will be stopped if playing.
*/
typedef void		(*PLUGIN_CLOSE_ALL)();
/*
	Closes the `Chroma` animation to free up resources referenced by id. Returns 
	the animation id upon success. Returns negative one upon failure. This 
	might be used while authoring effects if there was a change necessitating 
	re-opening the animation. The animation id can no longer be used once closed.
*/
typedef int			(*PLUGIN_CLOSE_ANIMATION)(int animationId);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_CLOSE_ANIMATION_D)(double animationId);
/*
	Closes the `Chroma` animation referenced by name so that the animation can 
	be reloaded from disk.
*/
typedef void		(*PLUGIN_CLOSE_ANIMATION_NAME)(const char* path);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_CLOSE_ANIMATION_NAME_D)(const char* path);
/*
	`PluginCloseComposite` closes a set of animations so they can be reloaded 
	from disk. The set of animations will be stopped if playing.
*/
typedef void		(*PLUGIN_CLOSE_COMPOSITE)(const char* name);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_CLOSE_COMPOSITE_D)(const char* name);
/*
	Copy source animation to target animation for the given frame. Source and 
	target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ALL_KEYS)(int sourceAnimationId, int targetAnimationId, int frameId);
/*
	Copy source animation to target animation for the given frame. Source and 
	target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ALL_KEYS_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId);
/*
	Copy animation to named target animation in memory. If target animation 
	exists, close first. Source is referenced by id.
*/
typedef int			(*PLUGIN_COPY_ANIMATION)(int sourceAnimationId, const char* targetAnimation);
/*
	Copy animation to named target animation in memory. If target animation 
	exists, close first. Source is referenced by name.
*/
typedef void		(*PLUGIN_COPY_ANIMATION_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_ANIMATION_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Copy blue channel to other channels for all frames. Intensity range is 0.0 
	to 1.0. Reference the animation by id.
*/
typedef void		(*PLUGIN_COPY_BLUE_CHANNEL_ALL_FRAMES)(int animationId, float redIntensity, float greenIntensity);
/*
	Copy blue channel to other channels for all frames. Intensity range is 0.0 
	to 1.0. Reference the animation by name.
*/
typedef void		(*PLUGIN_COPY_BLUE_CHANNEL_ALL_FRAMES_NAME)(const char* path, float redIntensity, float greenIntensity);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_BLUE_CHANNEL_ALL_FRAMES_NAME_D)(const char* path, double redIntensity, double greenIntensity);
/*
	Copy green channel to other channels for all frames. Intensity range is 
	0.0 to 1.0. Reference the animation by id.
*/
typedef void		(*PLUGIN_COPY_GREEN_CHANNEL_ALL_FRAMES)(int animationId, float redIntensity, float blueIntensity);
/*
	Copy green channel to other channels for all frames. Intensity range is 
	0.0 to 1.0. Reference the animation by name.
*/
typedef void		(*PLUGIN_COPY_GREEN_CHANNEL_ALL_FRAMES_NAME)(const char* path, float redIntensity, float blueIntensity);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_GREEN_CHANNEL_ALL_FRAMES_NAME_D)(const char* path, double redIntensity, double blueIntensity);
/*
	Copy animation key color from the source animation to the target animation 
	for the given frame. Reference the source and target by id.
*/
typedef void		(*PLUGIN_COPY_KEY_COLOR)(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
/*
	Copy animation key color from the source animation to the target animation 
	for all frames. Reference the source and target by id.
*/
typedef void		(*PLUGIN_COPY_KEY_COLOR_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId, int rzkey);
/*
	Copy animation key color from the source animation to the target animation 
	for all frames. Reference the source and target by name.
*/
typedef void		(*PLUGIN_COPY_KEY_COLOR_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation, int rzkey);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_KEY_COLOR_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double rzkey);
/*
	Copy animation key color from the source animation to the target animation 
	for all frames, starting at the offset for the length of the source animation. 
	Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_KEY_COLOR_ALL_FRAMES_OFFSET)(int sourceAnimationId, int targetAnimationId, int rzkey, int offset);
/*
	Copy animation key color from the source animation to the target animation 
	for all frames, starting at the offset for the length of the source animation. 
	Source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_KEY_COLOR_ALL_FRAMES_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int rzkey, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_KEY_COLOR_ALL_FRAMES_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double rzkey, double offset);
/*
	Copy animation key color from the source animation to the target animation 
	for the given frame.
*/
typedef void		(*PLUGIN_COPY_KEY_COLOR_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_KEY_COLOR_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
/*
	Copy animation color for a set of keys from the source animation to the 
	target animation for the given frame. Reference the source and target by 
	id.
*/
typedef void		(*PLUGIN_COPY_KEYS_COLOR)(int sourceAnimationId, int targetAnimationId, int frameId, const int* keys, int size);
/*
	Copy animation color for a set of keys from the source animation to the 
	target animation for all frames. Reference the source and target by id.
*/
typedef void		(*PLUGIN_COPY_KEYS_COLOR_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId, const int* keys, int size);
/*
	Copy animation color for a set of keys from the source animation to the 
	target animation for all frames. Reference the source and target by name.
*/
typedef void		(*PLUGIN_COPY_KEYS_COLOR_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation, const int* keys, int size);
/*
	Copy animation color for a set of keys from the source animation to the 
	target animation for the given frame. Reference the source and target by 
	name.
*/
typedef void		(*PLUGIN_COPY_KEYS_COLOR_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, const int* keys, int size);
/*
	Copy animation color for a set of keys from the source animation to the 
	target animation from the source frame to the target frame. Reference the 
	source and target by id.
*/
typedef void		(*PLUGIN_COPY_KEYS_COLOR_OFFSET)(int sourceAnimationId, int targetAnimationId, int sourceFrameId, int targetFrameId, const int* keys, int size);
/*
	Copy animation color for a set of keys from the source animation to the 
	target animation from the source frame to the target frame. Reference the 
	source and target by name.
*/
typedef void		(*PLUGIN_COPY_KEYS_COLOR_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int sourceFrameId, int targetFrameId, const int* keys, int size);
/*
	Copy source animation to target animation for the given frame. Source and 
	target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS)(int sourceAnimationId, int targetAnimationId, int frameId);
/*
	Copy nonzero colors from a source animation to a target animation for all 
	frames. Reference source and target by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Copy nonzero colors from a source animation to a target animation for all 
	frames. Reference source and target by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Copy nonzero colors from a source animation to a target animation for all 
	frames starting at the offset for the length of the source animation. The 
	source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET)(int sourceAnimationId, int targetAnimationId, int offset);
/*
	Copy nonzero colors from a source animation to a target animation for all 
	frames starting at the offset for the length of the source animation. The 
	source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double offset);
/*
	Copy nonzero colors from source animation to target animation for the specified 
	frame. Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId);
/*
	Copy nonzero colors from the source animation to the target animation from 
	the source frame to the target offset frame. Source and target are referenced 
	by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_OFFSET)(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
/*
	Copy nonzero colors from the source animation to the target animation from 
	the source frame to the target offset frame. Source and target are referenced 
	by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_ALL_KEYS_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
/*
	Copy animation key color from the source animation to the target animation 
	for the given frame where color is not zero.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_KEY_COLOR)(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
/*
	Copy animation key color from the source animation to the target animation 
	for the given frame where color is not zero.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_KEY_COLOR_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_KEY_COLOR_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for the specified frame. Source and target 
	are referenced by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS)(int sourceAnimationId, int targetAnimationId, int frameId);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for all frames. Source and target are referenced 
	by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for all frames. Source and target are referenced 
	by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for all frames. Source and target are referenced 
	by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_OFFSET)(int sourceAnimationId, int targetAnimationId, int offset);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for all frames starting at the target offset 
	for the length of the source animation. Source and target animations are 
	referenced by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double offset);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for the specified frame. The source and target 
	are referenced by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for the specified source frame and target offset 
	frame. The source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_OFFSET)(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is nonzero for the specified source frame and target offset 
	frame. The source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_TARGET_ALL_KEYS_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is zero for all frames. Source and target are referenced 
	by id.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ZERO_ALL_KEYS_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Copy nonzero colors from the source animation to the target animation where 
	the target color is zero for all frames. Source and target are referenced 
	by name.
*/
typedef void		(*PLUGIN_COPY_NON_ZERO_TARGET_ZERO_ALL_KEYS_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_NON_ZERO_TARGET_ZERO_ALL_KEYS_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Copy red channel to other channels for all frames. Intensity range is 0.0 
	to 1.0. Reference the animation by id.
*/
typedef void		(*PLUGIN_COPY_RED_CHANNEL_ALL_FRAMES)(int animationId, float greenIntensity, float blueIntensity);
/*
	Copy green channel to other channels for all frames. Intensity range is 
	0.0 to 1.0. Reference the animation by name.
*/
typedef void		(*PLUGIN_COPY_RED_CHANNEL_ALL_FRAMES_NAME)(const char* path, float greenIntensity, float blueIntensity);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_RED_CHANNEL_ALL_FRAMES_NAME_D)(const char* path, double greenIntensity, double blueIntensity);
/*
	Copy zero colors from source animation to target animation for the frame. 
	Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS)(int sourceAnimationId, int targetAnimationId, int frameId);
/*
	Copy zero colors from source animation to target animation for all frames. 
	Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Copy zero colors from source animation to target animation for all frames. 
	Source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_ZERO_ALL_KEYS_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Copy zero colors from source animation to target animation for all frames 
	starting at the target offset for the length of the source animation. Source 
	and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET)(int sourceAnimationId, int targetAnimationId, int offset);
/*
	Copy zero colors from source animation to target animation for all frames 
	starting at the target offset for the length of the source animation. Source 
	and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int offset);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_ZERO_ALL_KEYS_ALL_FRAMES_OFFSET_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double offset);
/*
	Copy zero colors from source animation to target animation for the frame. 
	Source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId);
/*
	Copy zero colors from source animation to target animation for the frame 
	id starting at the target offset for the length of the source animation. 
	Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS_OFFSET)(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
/*
	Copy zero colors from source animation to target animation for the frame 
	id starting at the target offset for the length of the source animation. 
	Source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_ZERO_ALL_KEYS_OFFSET_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
/*
	Copy zero key color from source animation to target animation for the specified 
	frame. Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ZERO_KEY_COLOR)(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
/*
	Copy zero key color from source animation to target animation for the specified 
	frame. Source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_ZERO_KEY_COLOR_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_ZERO_KEY_COLOR_NAME_D)(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
/*
	Copy nonzero color from source animation to target animation where target 
	is zero for the frame. Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ZERO_TARGET_ALL_KEYS)(int sourceAnimationId, int targetAnimationId, int frameId);
/*
	Copy nonzero color from source animation to target animation where target 
	is zero for all frames. Source and target are referenced by id.
*/
typedef void		(*PLUGIN_COPY_ZERO_TARGET_ALL_KEYS_ALL_FRAMES)(int sourceAnimationId, int targetAnimationId);
/*
	Copy nonzero color from source animation to target animation where target 
	is zero for all frames. Source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_NAME)(const char* sourceAnimation, const char* targetAnimation);
/*
	D suffix for limited data types.
*/
typedef double		(*PLUGIN_COPY_ZERO_TARGET_ALL_KEYS_ALL_FRAMES_NAME_D)(const char* sourceAnimation, const char* targetAnimation);
/*
	Copy nonzero color from source animation to target animation where target 
	is zero for the frame. Source and target are referenced by name.
*/
typedef void		(*PLUGIN_COPY_ZERO_TARGET_ALL_KEYS_NAME)(const char* sourceAnimation, const char* targetAnimation, int frameId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_CREATE_CHROMA_LINK_EFFECT)(ChromaSDK::ChromaLink::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_CREATE_EFFECT)(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_CREATE_HEADSET_EFFECT)(ChromaSDK::Headset::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_CREATE_KEYBOARD_EFFECT)(ChromaSDK::Keyboard::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_CREATE_KEYPAD_EFFECT)(ChromaSDK::Keypad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_CREATE_MOUSE_EFFECT)(ChromaSDK::Mouse::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_CREATE_MOUSEPAD_EFFECT)(ChromaSDK::Mousepad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_DELETE_EFFECT)(RZEFFECTID EffectId);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_INIT)();
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_INIT_SDK)(ChromaSDK::APPINFOTYPE* AppInfo);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_QUERY_DEVICE)(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE& DeviceInfo);
/*
	Direct access to low level API.
*/
typedef RZRESULT	(*PLUGIN_CORE_SET_EFFECT)(RZEFFECTID EffectId);
/*
	Begin broadcasting Chroma RGB data using the stored stream key as the endpoint. 
	Intended for Cloud Gaming Platforms, restore the streaming key when the 
	game instance is launched to continue streaming. streamId is a null terminated 
	string streamKey is a null terminated string StreamGetStatus() should return 
	the READY status to use this method.
*/
typedef bool		(*PLUGIN_CORE_STREAM_BROADCAST)(const char* streamId, const char* streamKey);
/*
	End broadcasting Chroma RGB data. StreamGetStatus() should return the BROADCASTING 
	status to use this method.
*/
typedef bool		(*PLUGIN_CORE_STREAM_BROADCAST_END)();
/*
	shortcode: Pass the address of a preallocated character buffer to get the 
	streaming auth code. The buffer should have a minimum length of 6. length: 
	Length will return as zero if the streaming auth code could not be obtained. 
	If length is greater than zero, it will be the length of the returned streaming 
	auth code. Once you have the shortcode, it should be shown to the user 
	so they can associate the stream with their Razer ID StreamGetStatus() 
	should return the READY status before invoking this method. platform: is 
