# CampusQuest

> Making campus exploration immersive, intuitive and engaging.

CampusQuest is a gamified 3D campus navigation and exploration system built using Unity. It enables users to navigate large campus environments through interactive quests, teleportation, real-time navigation aids and intuitive UI systems.

Rather than relying on traditional static maps, CampusQuest transforms campus discovery into an immersive experience where users can explore buildings, complete location-based quests, unlock rewards and navigate the campus using multiple navigation systems.

---

## Features

### Campus Navigation

- Fully explorable 3D campus environment.
- First person player movement system.
- Real-time minimap navigation.
- Interactive campus map with building labels.
- Teleportation based navigation.
- Direction based navigation with distance tracking.
- Location based quest navigation.

### Quest System

- Complete campus exploration quests.
- Reach designated campus locations.
- Progress tracking system.
- Reward and badge based progression.
- Interactive quest menu.

Current quest locations include:

- Lecture Hall Complex (LHC)
- Main Gate
- Sports Block
- Residential Complex
- Library
- Old Academic Building
- RnD Block
- Hostels

---

## New UI System

CampusQuest now features a completely redesigned and user-friendly interface including:

- Main Menu Screen
- Pause Menu
- Options Panel
- Quest and Rewards Panel
- Interactive Campus Map
- Minimap System
- Navigation Menus
- Teleportation Menu
- Direction Selection Menu

The entire UI has been redesigned to provide a cleaner and more intuitive user experience.

---

## Navigation Systems

CampusQuest currently provides multiple navigation methods:

### Movement System

- WASD movement
- Mouse based camera controls
- Sprinting
- Jump mechanics
- Crouching support

### Teleportation

Users can instantly travel to important campus locations through the teleportation menu.

Features include:

- Sound cues
- Location selection system
- Instant teleportation
- Seamless integration with navigation systems

### Direction Navigation

The direction system provides:

- Real-time distance calculations
- Direction indicators
- Dynamic destination selection
- Navigation assistance throughout the campus

### Interactive Campus Map

Press:

```
M
```

to open the campus map.

Features include:

- Building labels
- Campus overview
- Easy location identification
- Interactive navigation support

---

## Performance Optimization

CampusQuest is currently undergoing extensive optimization for larger campus environments.

Implemented optimizations include:

- Occlusion Culling
- Camera optimization
- Selective scene baking
- Large scene management
- Dynamic object handling

Current research includes:

- Render distance optimization
- Fog based optimization techniques
- User configurable graphics settings
- Device specific performance configurations

The goal is to allow users with different hardware specifications to customize and optimize their experience accordingly.

---

## AR Research

CampusQuest is currently exploring Augmented Reality based campus experiences.

Current progress includes:

- Research on campus scanning workflows.
- LHC scans using the PolCam application on iOS.
- Initial scans of the RnD block.
- AR integration research and experimentation.

This functionality is currently under active development.

---

## Technologies Used

| Category | Technology |
|----------|------------|
| Game Engine | Unity 6 |
| Language | C# |
| UI System | Unity UI |
| Version Control | Git + GitHub |
| Optimization | Occlusion Culling |
| Platform | Windows |
| AR Research | PolCam (iOS) |

---

## Current Progress

### Completed

- [x] Player Movement System
- [x] Camera System
- [x] Main Menu Implementation
- [x] Minimap Navigation
- [x] Interactive Campus Map
- [x] Quest System
- [x] Reward System Framework
- [x] Teleportation System
- [x] Direction Navigation System
- [x] Sound Cue Integration
- [x] Campus Model Integration
- [x] Performance Optimization (Phase 1)
- [x] UI Redesign
- [x] Github Integration

### Under Development

- [ ] Advanced Optimization Techniques
- [ ] AR Integration
- [ ] User Configurable Graphics Settings
- [ ] Additional Quest Content
- [ ] Improved Performance Scaling
- [ ] Additional Navigation Features

### Planned

- [ ] Android Support
- [ ] WebGL Support
- [ ] Expanded Campus Areas
- [ ] Advanced AR Experiences
- [ ] Accessibility Improvements

---

## Controls

| Action | Key |
|--------|-----|
| Move Forward | W |
| Move Backward | S |
| Move Left | A |
| Move Right | D |
| Jump | Space |
| Sprint | Left Shift |
| Crouch | R |
| Look Around | Mouse |
| Open Campus Map | M |
| Pause Menu | Esc |

---

## Human Computer Interaction Principles

CampusQuest follows several Human Computer Interaction principles including:

- Affordance
- Discoverability
- Immediate Feedback
- Consistency
- Visibility of System Status
- User Control and Freedom
- Learnability
- Accessibility

These principles guide both navigation and interaction design throughout the project.

---

## Folder Structure

```

Assets/
│
├── Scenes/
├── Scripts/
├── Models/
├── Prefabs/
├── Resources/
├── Fonts/
├── Audio/
├── Settings/
├── StarterAssets/
└── UI/

```

---

## How To Run

### Requirements

- Unity Hub
- Unity 6 (6000.4.0f1)
- Git (Recommended)

---

### Method 1 : Clone the Repository

```bash
git clone <repository-link>
```

Then:

1. Open Unity Hub.
2. Click "Add Project from Disk".
3. Select the CampusQuest folder.
4. Open the project using Unity 6.
5. Allow Unity to import all assets and packages.
6. Open the following scene:

```
Assets > Scenes > MainCampusQuest
```

7. Press Play.

---

### Method 2 : Download ZIP

1. Download the repository as ZIP.
2. Extract the folder.
3. Open Unity Hub.
4. Click "Add Project from Disk".
5. Select the extracted folder.
6. Open the project using Unity 6.
7. Allow Unity to finish importing assets.
8. Open:

```
Assets > Scenes > MainCampusQuest
```

9. Press Play.

---

## Roadmap

### Phase 1

- Campus Navigation Systems
- Quest Systems
- UI Redesign
- Performance Optimization

### Phase 2

- Advanced Optimization
- AR Integration
- Graphics Configuration Options
- Additional Campus Content

### Phase 3

- Android Deployment
- WebGL Deployment
- Enhanced Campus Experiences
- Accessibility Improvements

---

## Team

- Luvya Nishad
- Yuvraj Singh
- Taksh Dalal

---

## Project Status

CampusQuest is currently under active development. Major gameplay, navigation and quest systems have been implemented successfully, while optimization, AR integration and platform expansion are ongoing.

---

## Future Scope

- Android Compatibility
- WebGL Support
- AR Based Campus Experiences
- Personalized Campus Tours
- Enhanced Accessibility Features
- Advanced Navigation Systems
- Dynamic Performance Scaling

---

## License

This project is intended for academic and research purposes.

---

> CampusQuest aims to bridge the gap between traditional campus maps and immersive exploration by making navigation intuitive, engaging and accessible for every user.